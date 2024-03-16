import { useEffect, useState } from 'react';
import { Bowlers } from '../types/Bowlers';

function BowlersList() {
  const [bowlersData, setBowlersData] = useState<Bowlers[]>([]);

  useEffect(() => {
    const fetchBowlersData = async () => {
      const rsp = await fetch(
        'http://localhost:5101/Bowlers/bowlers-with-teams',
      );
      const f = await rsp.json();
      setBowlersData(f);
    };
    fetchBowlersData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">List of Bowlers</h4>
      </div>
      <table className="table table-bordered">
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
        <tbody>
          {bowlersData
            .filter(
              (bowler) =>
                bowler.teamName === 'Marlins' || bowler.teamName === 'Sharks',
            )
            .map((f, index) => (
              <tr key={f.bowlerId}>
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
