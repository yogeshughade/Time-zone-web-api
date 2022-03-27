export class ItemService {
  baseUrl = environment.apiUrl;
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'TimeZone-Offset': `${new Date().getTimezoneOffset()}`
    })
  }

  constructur(private authHttp: HttpClient) { }

  getItems() {
    return this.authHttp.get<Item[]>(this.baseUrl + 'items', 
      { headers: this.httpOptions.headers });
  }
}
