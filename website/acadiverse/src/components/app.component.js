import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Tab } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
import Footer from './footer.component';
import ChatsComponent from './chats.component';
import StoreComponent from './store.component';
const panes = [
                { menuItem: 'Tab 1', pane: <ChatsComponent /> },
                { menuItem: 'Tab 2', pane: <StoreComponent /> },
                { menuItem: 'Tab 3', pane: 'Tab 3 Content' },
]

export default class AppComponent extends Component {

    render() {
        return (
            <Container fluid>
                <NavigationBar activeItem="" />
                <Tab panes={panes} />
                <Footer />
            </Container>
        )
    }
}