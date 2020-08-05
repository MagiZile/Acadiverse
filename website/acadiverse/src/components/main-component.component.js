import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container, Modal } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
import Footer from './footer.component';

import '../index.css';

export default class MainComponent extends Component {
    state = {}
    render() {
        const { activeItem } = this.state;
        
        return (
            <Container fluid>
                <NavigationBar activeItem="" />
                <div id="content">
                    <h1 id="header">
                        No more boredom in class.
                    </h1>
                    <h2>
                        Acadiverse is a free gamified learning platform that makes class much more fun and engaging, Instead of learning through boring lectures and worksheets, you can learn through lessons (these are called "quests" in-game) and also explore and interact with a large voxel-based world.
                    </h2>
                    <h2>
                        Teachers can make their own areas of the game world using the easy-to-use Acadiverse Lesson Studio, which was designed with simplicity and efficiency in mind.
                    </h2>
                    <h3>Does all of this sound interesting to you? Click <a href="/about">here</a> to learn more about Acadiverse, or log in or sign up by clicking on the Register or Login button on the top right of the page.</h3>             
                </div>
                <Footer />
            </Container>
        )
    }
}