const mongoose = require('mongoose');
const Schema = mongoose.Schema;

let Account = new Schema({
    username: {
        type: String,
        unique: true
    },
    password: {
        type: String
    },
    account_type: {
        type: String
    },
    reputation_points: {
        type: Integer,
        default: 0
    },
    money: {
        type: Integer,
        default: 0
    },
    infraction_history: {
        type: Array,
        default: []
    },
    account_banned: {
        type: Boolean,
        default: false
    },
    date_ban_expires: {
        type: Date,
        default: new Date("1/1/1970")
    },
    ban_reason: {
        type: String,
        default: ""
    },
    can_publish: {
        type: Boolean,
        default: true
    },
    can_chat: {
        type: Boolean,
        default: true
    },
    account_creation_date: {
        type: Date
    },
    last_login_date: {
        type: Date
    },
    birthday: {
        type: Date
    },
    profile_bio: {
        type: String,
        default: "This user currently does not have a bio."
    },
    email: {
        type: String
    },
    chat_strikes: {
        type: Integer,
        default: 0
    },
    publishing_strikes: {
        type: Integer,
        default: 0
    },
    warnings: {
        type: Integer,
        default: 0
    },
    notifications: {
        type: Array,
        default: []
    },
    notify_achievement_received: {
        type: Boolean,
        default: true
    },
    notify_submission_featured: {
        type: Boolean,
        default: true
    },
    notify_mentioned: {
        type: Boolean,
        default: true
    },
    notify_submission_comment: {
        type: Boolean,
        default: true
    },
    notify_submission_upvote: {
        type: Boolean,
        default: true
    },
    notify_pm_received: {
        type: Boolean,
        default: true
    },
    receives_pms: {
        type: Boolean,
        default: true
    },
    blocked_users: {
        type: Array,
        default: []
    },
    acknowledged_last_warning: {
        type: Boolean,
        default: true
    },
    last_warned_by_moderator_name: {
        type: String,
        default: ""
    },
    date_last_warning_received: {
        type: Date,
        default: new Date(0)
    },
    last_warning_reason: {
        type: String,
        default: ""
    },
    profile_image_data: {
        type: Buffer,
        default: new Buffer()
    }   
});

module.exports = mongoose.model('Account', Account);