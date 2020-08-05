import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
import Footer from './footer.component';
export default class AboutComponent extends Component {
    state = {}

    render() {
        return (
        <Container fluid>
            <NavigationBar activeItem = "" />
            <h1>Error 404</h1>
            <h2>The page you are trying to access does not exist.</h2>
            <Footer />
        </Container>
        )
    }
}