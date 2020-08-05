import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import AdBlockDetect from 'react-ad-block-detect';
import { withRouter } from 'react-router-dom';
import { Button, Menu, Advertisement, Container } from 'semantic-ui-react';
import NavigationBar from './navigation.component';
import Footer from './footer.component';
export default class AboutComponent extends Component {
    state = {}

    render() {
        return (
        <Container fluid>
            <NavigationBar activeItem = "about" />
                <h1>About Acadiverse</h1>
		<h2>Free game-based learning.</h2>
		<p>Acadiverse is an innovative game-based learning platform. Rather than just learning by watching videos or reading text, players can interact with each other in a large, voxel-based world. Teachers can also create their own "scenarios", which are basically 3D worlds focused around a certian topic. There are also scenarios that we have already made.</p>
		<p>The gamified elements/features of Acadiverse are:</p>
		<ul>
			<li>Each scenario has unique achievements and other rewards, which teachers can set for each scenario.</li>
			<li>Acadicoins, Acadiverse's currency, can be earned by playing in scenarios and doing well on quizzes.</li>
			<li>Each scenario can also be part of a "lesson", making it possible for an entire course to be done using Acadiverse!</li>
			<li>Acadiverse's advantages over other gamified learning systems is that it is completely free and easy to use, both at school and at home!</li>
		</ul>
		
		<h2>Acadiverse Lesson Studio</h2>
		<p>Acadiverse Lesson Studio is a free program that teachers can use to make scenarios for Acadiverse. It is easy to learn, and there is also a way to preview your scenarios in the game.</p>
		
		<h2>Our Values</h2>
		<p>We value free and fun learning, community, diversity, respect, and responsibility.</p>
		
		<h3>Free and Fun Learning</h3>
		<p>We believe that education/learning should be free and fun for all. Some news sources are saying that test scores are falling across the United States, especially in reading and math. We believe that the way to turn the country's grades around and better educate future generations is to make learning more fun. Schools also often have low budgets, so offering Acadiverse for free should help in those cases as well.</p>
		
		<h3>Community</h3>
		<p>Learning alone is no fun, so we believe that people learn better when part of a community. We have many ways of getting the community together, including in-game chat as well as a <a href="http://reddit.com/r/Acadiverse">Reddit community</a> for discussing Acadiverse-related topics with other players.</p>
		
		<h3>Diversity</h3>
		<p>We welcome all people on Acadiverse, provided that they follow our <a href="/code-of-conduct">Code of Conduct</a>. We believe that anyone should have access to these services.</p>
		
		<h3>Respect</h3>
		<p>We believe that a community only thrives if people respect one another. Players should treat each other as they would in person, as you should always treat others the way you want to be treated. Also, respect authorities such as teachers as well as our Moderators.</p>
		
		<h3>Responsibility</h3>
		<p>We believe that all of our players should be responsible. Teachers hold the responsibility of creating good scenarios, parents are responsible for helping their children succeed, and the responsibility of students is to always listen to thair teachers.</p>
            <Footer />
        </Container>
        )
    }
}