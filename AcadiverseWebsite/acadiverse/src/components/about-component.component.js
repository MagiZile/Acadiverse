import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
export default class AboutComponent extends Component {
    state = {}

    render() {
        return (
            <NavigationBar activeItem = "about" />
        )
    }
}