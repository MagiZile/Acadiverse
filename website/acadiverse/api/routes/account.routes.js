module.exports = app => {
	var router = require("express").Router();

	router.post("/", accounts.create);

	router.get("/", accounts.findAll);

	router.get("/:id", accounts.findOne);

	router.put("/:id", accounts.update);

	router.delete("/:id", accounts.delete);

	app.use('/api/accounts', router);
}