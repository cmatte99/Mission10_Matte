import React from 'react';
import './App.css';
import Header from './Header';
import BowlersList from './Bowlers/BowlersList';

// Functional component to display a welcome message
function Welcome() {
  return <h1>Bowlers</h1>;
}

// Functional component to display random content
function Content() {
  return (
    <>
      <p>Here is a random number </p>
      <h3>{Math.random()}</h3>
    </>
  );
}

// Functional component to display a footer message
function Footer() {
  return <footer>Come back</footer>;
}

// Main component of the application
function App() {
  return (
    <div className="App">
      {/* Render the Header component */}
      <Header />
      {/* Render the BowlersList component */}
      <BowlersList />
    </div>
  );
}

export default App;
