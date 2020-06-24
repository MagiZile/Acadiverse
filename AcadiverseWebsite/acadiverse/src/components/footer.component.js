import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { Route } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
export default class Footer extends Component {
    render() {   
        return (
            <Route render={({ history }) => (
                <Container fluid>
                    <hr />
                    <footer>
                        <p>
                            &copy; 2020 MagiZile.
                    </p>
                        <p>
                            <a href="/code-of-conduct">Code of Conduct</a> | <a href="terms-of-service">Terms of Service</a>
                        </p>
                    </footer>
                </Container>
            )} />
        )
    }
}