import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { Route } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Icon } from 'semantic-ui-react';
export default class DownloadButton extends Component {
    downloadFile = () => {
        window.location.href = this.props.filePath
    }  
    render() {   
        return (
              
            <Button icon labelPosition="left" onClick={this.downloadFile}>
                    <Icon name="download" />
                    Download
            </Button>
        )
    }
}