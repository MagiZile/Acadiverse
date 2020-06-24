import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container.Modal } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
export default class AboutComponent extends Component {
    

    state = { modalOpen: false }

    handleClose = () => this.setState({ modalOpen: false })

    render() {
        return (
            <Modal modalOpen={false}>
                <Modal.Content image>
                    <Header>You have received a warning from a moderator!</Header>
                    <p>
                        You have received a warning for the following reason:
                    </p>
                    <p>
                        
                    </p>
                    <p>
                        This warning was given on {date} by <a href={moderatorProfileLinkURL}> {moderatorName}</a>.
                    </p>
                    <p>
                        Please review our <a href="/code-of-conduct">Code of Conduct</a> and <a href="/terms-of-service">Terms of Service</a>, then click "Acknowledge Wadning" to acknowledge this warning.
                    </p>
                </Modal.Content>
                <Modal.Actions>
                    <Button onClick={this.handleClose}>Acknowledge Warning</Button>
                </Modal.Actions>
                </Modal>
            </Modal>
        )
    }
}