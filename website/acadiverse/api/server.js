const express = require('express');
const app = express();
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const accountRoutes = express.Router();
const dotenv = require("dotenv");
const cors = require("cors");

app.use(cors());
app.use(bodyParser.json());
app.use('/account', accountRoutes);

dotenv.config();
mongoose.connect(process.env.CONNECTION_STRING, {
    useNewUrlParser: true,
    useUnifiedTopology: true,
},
() => console.log("Connected to database.")
);

// import routes
const authRoutes = require("./routes/auth");
const dashboardRoutes = require("./routes/dashboard");
const verifyToken = require("./routes/validate-token");

// middlewares
app.use(express.json()); // for body parser

// route middlewares
app.use("/api/user", authRoutes);
app.use("/api/dashboard", verifyToken, dashboardRoutes);

require('./routes/account.routes');

app.listen(4000, () => console.log("server is running..."));