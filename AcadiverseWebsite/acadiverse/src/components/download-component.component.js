import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
import DownloadButton from './download_button.component';
export default class DownloadComponent extends Component {
    state = {}

    render() {
        const { activeItem } = this.state;
        return (
            <Container fluid>
                <NavigationBar activeItem="download" />
                <h1>Download Acadiverse</h1>
                <h2>Acadiverse for Windows/macOS</h2>
                <p>Acadiverse Desktop Client is a Windows or macOS application that allows not only launching Acadiverse (the actual game), but it also allows you to easily manage your chats, submissions, and downloads all in one place!</p>
                <p>Acadiverse Desktop Client also allows teachers to access Acadiverse Lesson Studio, which makes it easy to create lessons (called "quests" in-game) or lesson collections (called "Acadiverse Spaces" in-game).</p>
                <br />
                <h3>Windows Download: </h3>
                <DownloadButton filePath="https://acadiverse.magizile.com/downloads/AcadiverseDesktopClientInstaller.exe" />
                <br />
                <h3>macOS Download: </h3>
                <DownloadButton filePath="https://acadiverse.magizile.com/downloads/AcadiverseDesktopClientInstaller.dmg" />
                <h2>Acadiverse for Android/iOS</h2>
                <p>Acadiverse's official mobile apps allow interacting with/managing your chats and submissions on-the-go! Teachers can also use it to view classroom stats and access other tools related to their classes. We also have a mobile version of the Acadiverse game so that students and teachers can play even if they do not have access to a computer!</p>
            </Container>
        )
    }
}