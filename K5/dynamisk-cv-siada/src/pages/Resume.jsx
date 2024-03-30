import React from 'react';
import data from '../../data.json';
import './Resume.css';

export default function Resume() {
  return (
    <>
      <div className="spacer"></div>
      <div className="resume">
        <React.Fragment>
          <header>
            <div key={data.info.name}>
              <h1>{data.info.name}</h1>
              <div className="contact-info">
                <p>{data.info.location}</p>
                <p>Phone: {data.info.phone}</p>
                <p>Email: {data.info.email}</p>

                <div className="social">
                  <p>LinkedIn:</p>
                  <a href={data.info.linkedin}>{data.info.linkedin}</a>
                </div>
                <div className="social">
                  <p>GitHub:</p>
                  <a href={data.info.github}>{data.info.github}</a>
                </div>
                <div className="social">
                  <p>Website:</p>
                  <a href={data.info.website}>{data.info.website}</a>
                </div>
              </div>
            </div>
          </header>

          <div className="experience">
            <h2>Arbetslivserfarenhet</h2>
            {data.experiences.map((job) => (
              <div key={job.company}>
                <h3>
                  {job.company} - {job.location} ({job.startDate} –{' '}
                  {job.endDate})
                </h3>
                <p>{job.position}</p>
                <ul>
                  {job.responsibilities.map((responsibility) => (
                    <li key={responsibility}>{responsibility}</li>
                  ))}
                </ul>
              </div>
            ))}
          </div>

          <div className="education">
            <h2>Utbildning</h2>
            {data.education.map((school) => (
              <div key={school.school}>
                <h3>
                  {school.school} - {school.location} ({school.startDate} –{' '}
                  {school.endDate})
                </h3>
                <p>{school.degree}</p>
              </div>
            ))}
          </div>

          <div className="skills">
            <h2>Färdigheter</h2>
            <ul>
              {data.skills.map((skill) => (
                <li key={skill}>{skill}</li>
              ))}
            </ul>
          </div>
        </React.Fragment>
      </div>
    </>
  );
}
