import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
export default class AppComponent extends Component {
    state = {}

    render() {
        const { activeItem } = this.state;
        return (
            <NavigationBar activeItem = "chats" />
        )
    }
}