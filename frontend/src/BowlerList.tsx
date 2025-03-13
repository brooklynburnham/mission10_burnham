import { useEffect, useState } from "react";
import { Bowler, ApiResponse } from "./types/bowler"; // Import your Bowler type

function BowlerList() {
  const [bowlers, setBowlers] = useState<Bowler[]>([]);
  useEffect(() => {
    const fetchBowlers = async () => {
      const response = await fetch("http://localhost:5000/api/bowlers");
      const data: ApiResponse = await response.json();
      console.log(data);
      setBowlers(data["$values"]);
    };
    fetchBowlers();
  }, []);

  return (
    <>
      <h1>Bowling League Bowlers</h1>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((bowler) => (
            <tr key={bowler.bowlerID}>
              <td>
                {bowler.bowlerFirstName}, {bowler.bowlerMiddleInit},{" "}
                {bowler.bowlerLastName}
              </td>
              <td>{bowler.teamName}</td>
              <td>{bowler.bowlerAddress}</td>
              <td>{bowler.bowlerCity}</td>
              <td>{bowler.bowlerState}</td>
              <td>{bowler.bowlerZip}</td>
              <td>{bowler.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
