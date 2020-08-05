import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { Route } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Modal, Dropdown, Item } from 'semantic-ui-react';
import RegisterForm from './register.component';
import LoginForm from './login.component';

import '../index.css';

export default class StoreITem extends Component {

    render() {   
        return (
            <Route render={({ history }) => (
                <Container fluid>
                    <Item>
                        <Item.Image src={ this.props.image } />

                        <Item.Content>
                        <Item.Header as="a">{ this.props.name }</Item.Header>
                        <Item.Meta>
                            <span className="metadata">{ this.props.creatorName } (<a href="/profile/view/${this.props.creatorUserID}">{ this.props.creatorUsername }</a>)</span>
                            <span className="metadata">Item Type: { this.props.itemType }</span>
                            <span className="metadata">Price: { this.props.itemPrice } Acadicoins</span>
                        </Item.Meta>
                        <Item.Description>{ this.props.description }</Item.Description>
                        <Item.Extra>
                            <Button primary floated="right" onClick= {history.push("/store/item/${this.props.itemID}")}>View Details</Button>
                        </Item.Extra>
                        </Item.Content>
                    </Item>
                </Container>
            )} />
        )
    }
}