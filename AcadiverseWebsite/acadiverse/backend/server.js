const express = require('express');
const app = express();
const bodyParser = require('body-parser');
const cors = require('cors');
const mongoose = require('mongoose');
const PORT = 4000;
const CONNECTION_STRING = 'mongodb+srv://admin:o5b8NeDcgO9yF9jn@acadiverse.axveq.gcp.mongodb.net/acadiverse?retryWrites=true&w=majority';
const accountRoutes = express.Router();
const MongoClient = require('mongodb').MongoClient;
const Account = require('./models/account.model.js');

app.use(cors());
app.use(bodyParser.json());
app.use('/account', accountRoutes);

app.listen(PORT, function() {
    console.log("Server is running on port: " + PORT);
});

mongoose.connect(CONNECTION_STRING, { useNewUrlParser: true });
const connection = mongoose.connection;
connection.once('open', _ => {
    console.log("Database connected: ", url)
})

connection.on("error", err => {
    console.error("failed to connect to the database: ", err)
})

MongoClient.connect(connectionString, (err, client) => {
    if (err) return console.error(err)
    console.log('Connected to Database')
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

async function createAccount(username, password, email, birthday, accountType) {
    const account = new Account({
        name: username,
        password: password,
        email: email,
        birthday: birthday,
        account_type: accountType,
        account_creation_date: Date.Now
    })

    account.save(function (error, document) {
        if (error) console.error(error)
        console.log(document)
    })
}

async function loadAccountData(username) {
    const accountData = await Account.FindOne({ name: username })
    return accountData
}