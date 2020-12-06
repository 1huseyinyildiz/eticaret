export class Enum {

  public static getKeys(enumerator) {
    const data: string[] = Object.keys(enumerator);
    return data.splice(data.length / 2, data.length / 2);
  }

  public static getValues(enumerator) {
    const data: string[] = Object.keys(enumerator);
    return data.splice(0, data.length / 2);
  }

}

export enum RoleType {
  Admin = 0,
  Manager= 1,
  Editor = 2
}
