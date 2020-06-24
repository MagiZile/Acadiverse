import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Form, Checkbox } from 'semantic-ui-react';
export default class LoginForm extends Component {
    state = {}

    handleSubmit = () => {

    }

    render() {
        return (
            <Form>
                <Form.Field>
                    <label>Username</label>
                    <input placeholder="enter your Acadiverse username." />
                </Form.Field>
                <Form.Field>
                    <label>Password</label>
                    <input type="password" />
                </Form.Field>
                <Form.Field>
                    <Checkbox label="Keep me logged in." />
                </Form.Field>
                <Button type="submit">Login</Button>
            </Form>
        )
    }
}