import { useEffect, useState } from 'react';
import { Bowlers } from '../types/Bowlers';

function BowlersList() {
  // State to hold bowlers data
  const [bowlersData, setBowlersData] = useState<Bowlers[]>([]);

  // Effect hook to fetch data when component mounts
  useEffect(() => {
    const fetchBowlersData = async () => {
      // Fetch data from API endpoint
      const rsp = await fetch(
        'http://localhost:5101/Bowlers/bowlers-with-teams',
      );
      // Parse JSON response
      const f = await rsp.json();
      // Set bowlers data to state
      setBowlersData(f);
    };
    // Call fetchBowlersData function
    fetchBowlersData();
  }, []);

  return (
    <>
      {/* Header */}
      <div className="row">
        <h4 className="text-center">List of Bowlers</h4>
      </div>
      {/* Table */}
      <table className="table table-bordered">
        {/* Table header */}
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Bowler Address</th>
            <th>Bowler City</th>
            <th>Bowler State</th>
            <th>Bowler Zip</th>
            <th>Bowler Phone</th>
          </tr>
        </thead>
        {/* Table body */}
        <tbody>
          {/* Map over bowlersData, filter and display bowler information */}
          {bowlersData
            .filter(
              (bowler) =>
                bowler.teamName === 'Marlins' || bowler.teamName === 'Sharks',
            )
            .map((f, index) => (
              <tr key={f.bowlerId}>
                {/* Concatenate first name, middle name (if exists), and last name */}
                <td>{`${f.bowlerFirstName} ${f.bowlerMiddleName ? f.bowlerLastName + ' ' : ''}${f.bowlerLastName}`}</td>
                <td>{f.teamName}</td>
                <td>{f.bowlerAddress}</td>
                <td>{f.bowlerCity}</td>
                <td>{f.bowlerState}</td>
                <td>{f.bowlerZip}</td>
                <td>{f.bowlerPhone}</td>
              </tr>
            ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlersList;
