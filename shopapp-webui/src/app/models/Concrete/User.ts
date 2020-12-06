export class User {

  public Name: string;
  public SurName: string;
  public UserName: string;
  public Email: string;
  public Password: string;
  public IsActive: boolean;
  public CompanyId: number;
  public RoleId: number;



  constructor() {
    this.Name = '';
    this.SurName = '';
    this.UserName = '';
    this.Email = '';
    this.Password = '';
    this.IsActive = false;
    this.CompanyId = 0;
    this.RoleId = 0;
  }
}
