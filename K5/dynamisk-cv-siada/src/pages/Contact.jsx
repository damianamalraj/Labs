import React from 'react';
import './Contact.css';

export default function Contact() {
  return (
    <section className="contact">
      <React.Fragment>
        <h1>Contact Me</h1>

        <form
          onSubmit={(event) => {
            event.preventDefault();
            alert('Form submitted');
          }}
          method="post"
        >
          <label>Name:</label>
          <input
            type="text"
            id="name"
            name="name"
            placeholder="Name"
            required
          />

          <label>Message:</label>
          <textarea
            id="message"
            name="message"
            rows="4"
            placeholder="Message"
            required
          ></textarea>

          <button>Submit</button>
        </form>
      </React.Fragment>
    </section>
  );
}
