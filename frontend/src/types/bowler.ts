export type Bowler = {
  bowlerID: number;
  bowlerFirstName: string;
  bowlerMiddleInit?: string;
  bowlerLastName: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;

  teamName: string;
};

export interface ApiResponse {
  $values: Bowler[];
}
