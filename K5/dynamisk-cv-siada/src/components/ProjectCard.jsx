import { useState } from 'react';
import PropTypes from 'prop-types';
import './ProjectCard.css';
import dotnetImage from '../assets/dotnet.png';
import restfulApiImage from '../assets/restful-api.png';

ProjectCard.propTypes = {
  project: PropTypes.object,
};

export default function ProjectCard({ project }) {
  const [isModalOpen, setIsModalOpen] = useState(false);

  const toggleModal = () => {
    setIsModalOpen(!isModalOpen);
  };

  const images = {
    'dotnet.png': dotnetImage,
    'restful-api.png': restfulApiImage,
  };

  return (
    <section className="card">
      <div className="image-container">
        <img
          src={images[project.imageSrc]}
          alt={project.altText}
          className="image"
        />
      </div>
      <h2>{project.title}</h2>
      <p className="cut-text">{project.summary}</p>
      <button className="info-button" onClick={toggleModal}>
        More information
      </button>
      {isModalOpen && (
        <div className="modal">
          <div className="modal-content">
            <h2>More information</h2>
            <p>{project.detailedInfo}</p>
            <button>
              <a
                href={project.githubLink}
                target="_blank"
                rel="noopener noreferrer"
              >
                GitHub Link
              </a>
            </button>
            <button className="close-button" onClick={toggleModal}>
              Close
            </button>
          </div>
        </div>
      )}
    </section>
  );
}
