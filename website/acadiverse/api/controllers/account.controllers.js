const db = require("../models");
const Account = db.account;

// Create and Save a new Tutorial
exports.create = (req, res) => {
  if (!req.body.username) {
    res.status(400).send({ message: "The request was empty." });
    return;
  }

  const account = new Account{(
    username: req.body.username,
    email: req.body.email
    password: req.body.password,
    birthday: req.body.birthday,
    accountType: req.body.accountType,
  });

  account
    .save(account)
    .then(data => {
      res.send(data);
    })
    .catch(err => {
      res.status(500).send({
        message: "An error occurred when creating a new account."
      });
    });
};


exports.findAll = (req, res) => {
  const username = req.query.username;
  var condition = username ? { username: { $regex: new RegExp(username), $options: "i" } } : {};

  username.find(condition)
    .then(data => {
      res.send(data);
    })
    .catch(err => {
      res.status(500).send({
        message:
          err.message || "An error occurred when attempting to retrieve all accounts.";
      });
    });
};

exports.findOne = (req, res) => {
    const id = req.params.id;

  Account.findById(id)
    .then(data => {
      if (!data)
        res.status(404).send({ message: "No account was found with id: " + id });
      else res.send(data);
    })
    .catch(err => {
      res
        .status(500)
        .send({ message: "An error occurred when trying to reteieve the account with id: " + id });
    });
};

exports.update = (req, res) => {
  if (!req.body) {
    return res.status(400).send({
      message: "Could not update as the data was empty."
    });
  }

  const id = req.params.id;

  Account.findByIdAndUpdate(id, req.body, { useFindAndModify: false })
    .then(data => {
      if (!data) {
        res.status(404).send({
          message: 'No account with id ${id} was found.'
        });
      } else res.send({ message: "Update successful." });
    })
    .catch(err => {
      res.status(500).send({
        message: "An error occurred when updating data." + id
      });
    });
};

exports.delete = (req, res) => {
  const id = req.params.id;

  Account.findByIdAndRemove(id)
    .then(data => {
      if (!data) {
        res.status(404).send({
          message: 'No account with id ${id} was found.'
        });
      } else {
        res.send({
          message: "Account successfully deleted."
        });
      }
    })
    .catch(err => {
      res.status(500).send({
        message: "An error occurred when trying to delete the account with id: " + id
      });
    });
};
