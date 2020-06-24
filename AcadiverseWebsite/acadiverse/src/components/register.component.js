import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Radio, Form } from 'semantic-ui-react';
export default class RegisterComponent extends Component {
    state = {}

    handleChange = (e, { value }) => this.setState({ value })

    handleSubmit = () => {

    }

    render() {
        return (
            <Form>
                <Form.Field>
                    <label>Username</label>
                    <input placeholder="Enter the username for your new account." />
                </Form.Field>
                <Form.Field>
                    <label>Password</label>
                    <input type="password" />
                </Form.Field>
                <Form.Field>
                    <label>Confirm PAssword</label>
                    <input type="password" />
                </Form.Field>
                <Form.Field>
                    <label>Birthday</label>
                    <input type="date" />
                </Form.Field>
                <Form.Field>
                    <label>Email</label>
                    <input type="email" />
                </Form.Field>
                <Form.Field>
                    <label>I am a:</label>
                    <Radio
                        label="Student"
                        name="accountType"
                        value="student"
                        checked={this.state.value === "student"}
                        onChange={this.handleChange}
                    />
                    <Radio
                        label="Teacher"
                        name="accountType"
                        value="teacher"
                        checked={this.state.value === "teacher"}
                        onChange={this.handleChange}
                    />
                    <Radio
                        label="Parent"
                        name="accountType"
                        value="parent"
                        checked={this.state.value === "parent"}
                        onChange={this.handleChange}
                    />
                </Form.Field>
            </Form>
        )
    }
}