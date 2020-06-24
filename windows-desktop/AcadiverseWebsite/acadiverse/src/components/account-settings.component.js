import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
export default class AccountSettingsComponent extends Component {
    state = {}

    render() {
        return (
            <Container fluid>
                <NavigationBar activeItem="" />
            </Container>
        )
    }
}