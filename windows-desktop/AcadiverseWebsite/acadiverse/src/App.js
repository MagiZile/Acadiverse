import React, { Component } from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import AppRoute from './AppRoute';
import ChatsComponent from "./components/chats.component";
import MainComponent from "./components/main-component.component";
import AboutComponent from "./components/about-component.component";
import DownloadComponent from "./components/download-component.component";
import BuddiesComponent from "./components/buddies.component";
import AccountSettingsComponent from "./components/account-settings.component";
import AppealComponent from "./components/appeal.component";

class App extends Component {
  render() {
    return (
      <Router>
            <Route path="/" exact component={MainComponent} />
            <Route path="/about" exact component={AboutComponent} />
            <Route path="/download" exact component={DownloadComponent} />
            <Route path="/chats" component={ChatsComponent} />
            <AppRoute path="/buddies" component={BuddiesComponent} />
            <AppRoute path="/account/settings" component={AccountSettingsComponent} />
            <Route path="/account/appeal" component={AppealComponent} />
      </Router>
    );
  }
}

export default App;
