const mongoose = require('mongoose');
const Schema = mongoose.Schema;

let Account = new Schema({
    username: {
        type: String
    },
    password: {
        type: String
    },
    account_type: {
        type: String
    },
    reputation_points: {
        type: Integer
    },
    money: {
        type: Integer
    },
    infraction_history: {
        type: Array
    },
    account_banned: {
        type: Boolean
    },
    date_ban_expires: {
        type: Date
    },
    ban_reason: {
        type: String
    },
    can_publish: {
        type: Boolean
    },
    can_chat: {
        type: Boolean
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
        type: String
    },
    email: {
        type: String
    },
    chat_strikes: {
        type: Integer
    },
    publishing_strikes: {
        type: Integer
    },
    warnings: {
        type: Integer
    },
    notifications: {
        type: Array
    },
    notify_achievement_received: {
        type: Boolean
    },
    notify_submission_featured: {
        type: Boolean
    },
    notify_mentioned: {
        type: Boolean
    },
    notify_submission_comment: {
        type: Boolean
    },
    notify_submission_upvote: {
        type: Boolean
    },
    notify_pm_received: {
        type: Boolean
    },
    receives_pms: {
        type: Boolean
    },
    blocked_users: {
        type: Array
    },
    acknowledged_last_warning: {
        type: Boolean
    },
    last_warned_by_moderator_name: {
        type: String
    },
    date_last_warning_received: {
        type: Date
    },
    last_warning_reason: {
        type: String
    },
    profile_image_data: {
        type: Buffer
    }   
});

module.exports = mongoose.model('Account', Account);