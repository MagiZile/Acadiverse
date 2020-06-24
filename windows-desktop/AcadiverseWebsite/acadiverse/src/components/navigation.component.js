import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { Route } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
export default class NavigationBar extends Component {
    render() {   
        return (
            <Route render={({ history }) => (
                <Container fluid>
                    <Menu>
                        <h2>Acadiverse</h2>
                        <Menu.Item
                            name=""
                            active={this.props.activeItem === ""}
                            onClick={() => { history.push("/") }}
                        >
                            Home
                    </Menu.Item>

                        <Menu.Item
                            name="about"
                            active={this.props.activeItem === "about"}
                            onClick={() => { history.push("/about") }}
                        >
                            About
                    </Menu.Item>

                        <Menu.Item
                            name="download"
                            active={this.props.activeItem === "download"}
                            onClick={() => { history.push("/download") }}
                        >
                            Downloads
                    </Menu.Item>

                        <Menu.Item
                            name="chats"
                            active={this.props.activeItem === "chats"}
                            onClick={() => { history.push("/chats") }}
                        >
                            Chats
                        </Menu.Item>

                        <Menu.Item>
                            <Button primary>Register</Button>
                        </Menu.Item>

                        <Menu.Item>
                            <Button>Login</Button>
                        </Menu.Item>
                    </Menu>

                    <Advertisement unit="banner" test="Banner" />
                    <AdBlockDetect>
                        <h1>Hi there! It looks like you are using an ad-blocker!</h1>
                        <h2>Sorry to bother you, but while Acadiverse is 100% free, these ads are necessary to cover the costs associated with running the site.</h2>
                        <p>Please whitelist this site. Alternatively, if you want to have an ad-free experience while still supporting the site, you can become a patron on Patreon!</p>
                    </AdBlockDetect>
                </Container>
            )} />
        )
    }
}