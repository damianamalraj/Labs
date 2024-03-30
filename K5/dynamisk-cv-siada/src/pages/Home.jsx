import React from 'react';
import './Home.css';
import profile from '../assets/profile.png';

export default function Home() {
  return (
    <article className="home">
      <React.Fragment>
        <div className="profile">
          <img src={profile} alt="profile picture" />
        </div>
        <h1>Welcome to my portfolio</h1>
        <h2>Hi, I&apos;m Damian 👋🏽</h2>
        <p>
          This is a simple portfolio website that I created using HTML and CSS.
          It is a static website, but I plan to add some interactivity using
          JavaScript in the future. I hope you enjoy your visit!
        </p>
      </React.Fragment>
    </article>
  );
}
