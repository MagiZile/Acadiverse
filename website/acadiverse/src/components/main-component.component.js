import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
import Footer from './footer.component';
export default class MainComponent extends Component {
    state = {}
    render() {
        const { activeItem } = this.state;
        return (
            <Container fluid>
                <NavigationBar activeItem="" />
                <h1 style={fontSize: 100>
                    No more boredom in class.
                </h1>
                <Footer />
            </Container>
        )
    }
}