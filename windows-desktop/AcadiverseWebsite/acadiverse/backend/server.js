const express = require('express');
const app = express();
const bodyParser = require('body-parser');
const cors = require('cors');
const mongoose = require('mongoose');
const PORT = 4000;
const accountRoutes = express.Router();

app.use(cors());
app.use(bodyParser.json());
app.use('/account', accountRoutes);



app.listen(PORT, function() {
    console.log("Server is running on port: " + PORT);
});

mongoose.connect('mongodb://127.0.0.1:27017/acadiverse', { useNewUrlParser: true });
const connection = mongoose.connection;

connection.once('open', function() {
    console.log("MongoDB database connection established successfully");
})

accountRoutes.route('/').get(function (req, res) {
    Account.find(function (err, accounts) {
        if (err) {
            console.log(err);
        } else {
            res.json(accounts)
        }
    });
});

accountRoutes.route('/:id').get(function (req, res) {
    let id = req.params.id;
    Account.findById(id, function (err, account) {
        res.json(account);
    });
});

accountRoutes.route('/register').post(function (req, res) {
    let account = new Account(req.body);
    account.save()
        .then(account => {
            res.status(200).json({ 'account': 'new account created successfully' });
        })
        .catch(err => {
            res.status(400).send('account creation failed!');
        });
});