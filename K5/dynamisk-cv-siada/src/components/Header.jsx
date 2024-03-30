import { Link } from 'react-router-dom';
import './Header.css';

export default function Header() {
  return (
    <nav>
      <ul>
        <li>
          <Link to="/Labs">Home</Link>
        </li>
        <li>
          <Link to="/about">About</Link>
        </li>
        <li>
          <Link to="/resume">Resume</Link>
        </li>
        <li>
          <Link to="/projects">Projects</Link>
        </li>
        <li>
          <Link to="/contact">Contact</Link>
        </li>
      </ul>
    </nav>
  );
}
