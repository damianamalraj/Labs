import data from '../../data.json';
import ProjectCard from '../components/ProjectCard';
import './Projects.css';
import React, { useEffect, useState } from 'react';

export default function Projects() {
  const [githubData, setGithubData] = useState();

  useEffect(() => {
    fetch('https://api.github.com/users/damianamalraj/repos')
      .then((response) => response.json())
      .then((data) => setGithubData(data));
  }, []);

  return (
    <React.Fragment>
      <section className="projects">
        {data.projects.map((project, index) => (
          <ProjectCard key={index} project={project} />
        ))}
      </section>
      <React.Fragment>
        <h1>My GitHub Repositories</h1>
        <section className="github-projects">
          {!githubData && <p>GitHub-projekt laddas...</p>}
          {githubData &&
            githubData.map((repo) => {
              return (
                <article key={repo.id}>
                  <span>{repo.visibility}</span>
                  <h2>{repo.name}</h2>
                  <p>{repo.language}</p>
                  <span>{repo.created_at}</span>
                </article>
              );
            })}
        </section>
      </React.Fragment>
    </React.Fragment>
  );
}
