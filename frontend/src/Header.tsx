function Header() {
  return (
    <header
      className="row"
      style={{ backgroundColor: 'darkblue', color: 'white' }}
    >
      <div className="col subtitle">
        {' '}
        Welcome to the Bowlers Database. Here, you can explore details about
        bowlers, including their names, team, address and contact info.{' '}
      </div>
    </header>
  );
}

export default Header;
