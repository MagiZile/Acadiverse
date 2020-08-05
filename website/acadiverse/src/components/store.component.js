import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Modal, Item, Label, Icon } from 'semantic-ui-react';
import StoreItem from './store.item.component';
import '../index.css';

export default class StoreComponent extends Component {
    state = {}
    render() {
        const { activeItem } = this.state;
        
        return (
            <Container fluid>
               <Item.Group divided>
                        
               </Item.Group>
            </Container>
        )
    }
}