import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { Route } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Modal, Dropdown } from 'semantic-ui-react';
import RegisterForm from './register.component';
import LoginForm from './login.component';

import '../index.css';

export default class NavigationBar extends Component {
     constructor(props) {
        super(props);
        /*
        this.onUsernameChanged = this.onUsernameChanged.bind(this);
        this.onDisplayNameChanged = this.onDisplayNameChanged.bind(this);
        this.onLogin = this.onLogin.bind(this);
        this.onLogout = this.onLogout.bind(this);
        this.onAccountDeleted = this.onAccountDeleted.bind(this);
        this.onAccountBanned = this.onAccounntBanned.bind(this);
        this.onWarningReceived = this.onWarningReceived.bind(this);
        */

        this.state = {
            loggedIn: false,
            id: null,
            username: "",
            display_name: "",
            account_type: "",
            reputation_points: 0,
            money: 0,
            infraction_history: null,
            account_banned: false,
            date_ban_expires: null, 
            ban_reason: "",
            can_publish: false,
            can_chat: false,
            account_creation_date: null, 
            last_login_date: null, 
            birthday: null,
            profile_bio: "",
            email: "",
            chat_strikes: 0,
            publishing_strikes: 0,
            warnings: 0,
            notifications: null,
            notify_achievement_received: false, 
            notify_submission_featured: false, 
            notify_mentioned: false, 
            notify_submission_comment: false, 
            notify_submission_upvote: false, 
            notify_pm_received: false, 
            receives_pms: false, 
            blocked_users: null,
            acknowledged_last_warning: false,
            last_warned_by_moderator_name: "",
            date_last_warning_received: null,
            last_warning_reason: "",
            profile_image_data: null
        }
    }

    onUsernameChanged(e) {
        this.setState({
            username: e.target.value
        });
    }

    onDisplayNameChanged(e) {
        this.setState({
            display_name: e.target.value
        });
    }

    onLogin(e) {
        this.setState({
            loggedIn: true,
            id: e.target.id,
            username: e.target.username,
            display_name: e.target.displayName,
            account_type: e.target.accountType,
            reputation_points: e.target.reputationPoints,
            money: e.target.money,
            infraction_history: e.target.infractionHistory,
            account_banned: false,
            date_ban_expires: null, 
            ban_reason: "",
            can_publish: e.target.canPublish,
            can_chat: e.target.canChat,
            account_creation_date: e.target.accountCreationDate, 
            last_login_date: Date.Now, 
            birthday: e.target.birthday,
            profile_bio: e.target.profileBio,
            email: e.target.email,
            chat_strikes: e.target.chatStrikes,
            publishing_strikes: e.target.publishingStrikes,
            warnings: e.target.warnings,
            notifications: e.target.notifications,
            notify_achievement_received: e.target.notifyAchievementReceived,
            notify_submission_featured: e.target.notifySubmissionFeatures,
            notify_mentioned: e.target.notifyMentioned,
            notify_submission_comment: e.target.notifySubmissionComment,
            notify_submission_upvote: e.target.notifySubmissionUpvote,
            notify_pm_received: e.target.notifySubmissionUpvote,
            receives_pms: e.target.receivesPMs,
            blocked_users: e.target.blockedUsers,
            acknowledged_last_warning: e.target.acknowledgedLastWarning,
            last_warned_by_moderator_name: e.target.lastWarnedByModeratorName,
            date_last_warning_received: e.target.dateLastWarningReceived,
            last_warning_reason: e.target.lastWarningReason,
            profile_image_data: e.target.profileImageData
        });
    }

    onLogout(e) {
        this.setState({
            loggedIn: false,
            id: null,
            username: "",
            display_name: "",
            account_type: "",
            reputation_points: 0,
            money: 0,
            infraction_history: null,
            account_banned: false,
            date_ban_expires: null, 
            ban_reason: "",
            can_publish: false,
            can_chat: false,
            account_creation_date: null, 
            last_login_date: null, 
            birthday: null,
            profile_bio: "",
            email: "",
            chat_strikes: 0,
            publishing_strikes: 0,
            warnings: 0,
            notifications: null,
            notify_achievement_received: false, 
            notify_submission_featured: false, 
            notify_mentioned: false, 
            notify_submission_comment: false, 
            notify_submission_upvote: false, 
            notify_pm_received: false, 
            receives_pms: false, 
            blocked_users: null,
            acknowledged_last_warning: false,
            last_warned_by_moderator_name: "",
            date_last_warning_received: null,
            last_warning_reason: "",
            profile_image_data: null
        });
    }

    onAccountDeleted(e) {
        this.setState({
            loggedIn: false,
            id: null,
            username: "",
            display_name: "",
            account_type: "",
            reputation_points: 0,
            money: 0,
            infraction_history: null,
            account_banned: false,
            date_ban_expires: null, 
            ban_reason: "",
            can_publish: false,
            can_chat: false,
            account_creation_date: null, 
            last_login_date: null, 
            birthday: null,
            profile_bio: "",
            email: "",
            chat_strikes: 0,
            publishing_strikes: 0,
            warnings: 0,
            notifications: null,
            notify_achievement_received: false, 
            notify_submission_featured: false, 
            notify_mentioned: false, 
            notify_submission_comment: false, 
            notify_submission_upvote: false, 
            notify_pm_received: false, 
            receives_pms: false, 
            blocked_users: null,
            acknowledged_last_warning: false,
            last_warned_by_moderator_name: "",
            date_last_warning_received: null,
            last_warning_reason: "",
            profile_image_data: null
        });
    }

    onAccountBanned(e) {
        this.setState({
            loggedIn: false,
            id: null,
            username: "",
            display_name: "",
            account_type: "",
            reputation_points: 0,
            money: 0,
            infraction_history: null,
            account_banned: false,
            date_ban_expires: null, 
            ban_reason: "",
            can_publish: false,
            can_chat: false,
            account_creation_date: null, 
            last_login_date: null, 
            birthday: null,
            profile_bio: "",
            email: "",
            chat_strikes: 0,
            publishing_strikes: 0,
            warnings: 0,
            notifications: null,
            notify_achievement_received: false, 
            notify_submission_featured: false, 
            notify_mentioned: false, 
            notify_submission_comment: false, 
            notify_submission_upvote: false, 
            notify_pm_received: false, 
            receives_pms: false, 
            blocked_users: null,
            acknowledged_last_warning: false,
            last_warned_by_moderator_name: "",
            date_last_warning_received: null,
            last_warning_reason: "",
            profile_image_data: null
          });
    }

    onWarningReceived(e) {
        this.setState({
              acknowledged_last_warning: false,
        last_warned_by_moderator_name: e.target.moderatorName,
        date_last_warning_received: e.target.warningDate,
        last_warning_reason: e.target.warningReason
        });
    }

    render() {   
        return (
            <Route render={({ history }) => (
                <Container fluid>
                    <Menu>
                        <h2><a href="/"><img src="http://acadiverse.magizile.com/images//logo.png" alt="Acadiverse" /></a></h2>
                        <Menu.Item
                            name=""
                            active={this.props.activeItem === ""}
                            onClick={() => { history.push("/") }}
                        >
                            Home
                    </Menu.Item>

                        <Menu.Item
                            name="about"
                            active={this.props.activeItem === "about"}
                            onClick={() => { history.push("/about") }}
                        >
                            About
                    </Menu.Item>

                        <Menu.Item
                            name="download"
                            active={this.props.activeItem === "download"}
                            onClick={() => { history.push("/download") }}
                        >
                            Downloads
                    </Menu.Item>

                        
                        {this.state.loggedIn ? 
                            <Menu.Item>
                                <Button primary onClick={() => { history.push("/app") }}>Open Acadiverse Online</Button>
                            </Menu.Item>
                        : null}
                        {this.state.loggedIn ? null : 
                        <Menu.Item>       
                            <Modal trigger={<Button primary>Register</Button>} id="modal">
                                <Modal.Content>
                                    <RegisterForm />
                                </Modal.Content>
                            </Modal>
                        </Menu.Item>}

                        {this.state.loggedIn ? null :     
                        <Menu.Item>
                            <Modal trigger={<Button>Login</Button>} id="modal">
                                <Modal.Content>
                                    <LoginForm />
                                </Modal.Content>
                            </Modal>
                        </Menu.Item>}

                        {this.state.loggedIn ?
                        <Menu.Item>                
                            <Dropdown text={ this.state.username }>
                                <Dropdown.Menu>
                                    <Dropdown.Item text="Profile" onClick={() => { history.push("account/profile")}} />
                                    <Dropdown.Item text="Account Settings" onClick={() => { history.push("/account/settings")}} />
                                    <Dropdown.Item text="My Items" onClick={() => { history.push("account/items")}} />
                                    <Dropdown.Item text="Buddies" onClick={() => { history.push("account/buddies")}} />
                                    <Dropdown.Item text="Log Out" />
                                </Dropdown.Menu>
                            </Dropdown>
                        </Menu.Item> : null}
                    </Menu>

                    <Advertisement unit="banner" test="Banner" />
                    <AdBlockDetect>
                        <h3>Hi there! It looks like you are using an ad-blocker!</h3>
                        <h4>Sorry to bother you, but while Acadiverse is 100% free, these ads are necessary to cover the costs associated with running the site.</h4>
                        <h4>Please whitelist this site. Alternatively, if you want to have an ad-free experience, get a special badge on your profile, and get some more extra perks while still supporting the site, you can become a patron on Patreon!</h4>
                    </AdBlockDetect>
                </Container>
            )} />
        )
    }
}