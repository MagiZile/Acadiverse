const router = require("express").Router();

// dashboard route
router.get("/", (req, res) => {
  res.json({
    error: null,
    data: {
      title: "Dashboard",
      content: "Hallo, " + req.user.username,
      user: req.user,
    },
  });
});

module.exports = router;