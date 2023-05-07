import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }

  login() {
    if (!this.isLoggedIn()) {
      this.saveToken();
    }
  }

  logout() {
    if (this.isLoggedIn()) {
      this.removeToken();
    }
  }

  isLoggedIn(): boolean {
    return this.retrieveToken() != null;
  }

  private saveToken() {
    localStorage.setItem('token', 'abcd');
  }

  private retrieveToken() {
    return localStorage.getItem('token');
  }

  private removeToken() {
    localStorage.removeItem('token');
  }
}
