import React from 'react';
import './App.css';
import Header from './Header';
import BowlersList from './Bowlers/BowlersList';

function Welcome() {
  return <h1>Bowlers</h1>;
}
function Content() {
  return (
    <>
      <p>Here is a random number </p>
      <h3>{Math.random()}</h3>
    </>
  );
}

function Footer() {
  return <footer>Come back</footer>;
}

function App() {
  return (
    <div className="App">
      <Header />
      <BowlersList />
    </div>
  );
}

export default App;
