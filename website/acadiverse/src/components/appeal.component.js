import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Form } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
export default class AppealComponent extends Component {
    state = {}

    render() {
        return (
            <Container fluid>
            <NavigationBar activeItem="" />
            <h1>Appeal a ban or other account restriction.</h1>
            <Form>
                <Form.Field>
                    <label>Username</label>
                    <input placeholder="Enter your username" />
                </Form.Field>
                <Form.Field>
                    <label>Please tell us why you believe that you should have not been banned or had a restriction placed on your account.</label>
                    <textarea placeholder="Please provide some information about why you should have your ban or restriction lifted." />
                    </Form.Field>
                </Form>
                <Button type="submit">Submit Appeal</Button>
            </Container>
        )
    }
}