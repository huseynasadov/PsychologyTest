import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export default class HttpService {
  public readonly questionUrl = 'api/questions';
  public readonly answerUrl = 'api/answers';

  private readonly defaultHttpOptions: IHttpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    }),
    observe: 'body',
    responseType: 'json'
  };

  public constructor(
    private readonly httpClient: HttpClient
  ) { }

  public get<T>(url: string, options: IHttpOptions = this.defaultHttpOptions): Promise<T> {
    return this.httpClient.get<T>(url, options).toPromise<T>();
  }

  public delete<T>(url: string, options: IHttpOptions = this.defaultHttpOptions): Promise<T> {
    return this.httpClient.delete<T>(url, options).toPromise<T>();
  }

  public put<T>(url: string, body: any, options: IHttpOptions = this.defaultHttpOptions): Promise<T> {
    return this.httpClient.put<T>(url, body, options).toPromise<T>();
  }

  public post<T>(url: string, body: any, options: IHttpOptions = this.defaultHttpOptions): Promise<T> {
    return this.httpClient.post<T>(url, body, options).toPromise<T>();
  }

  public patch<T>(url: string, body: any, options: IHttpOptions = this.defaultHttpOptions): Promise<T> {
    return this.httpClient.patch<T>(url, body, options).toPromise<T>();
  }

  public postAsync<T>(url: string, body: any, options: IHttpOptions = this.defaultHttpOptions): Observable<T> {
    return this.httpClient.post<T>(url, body, options);
  }
}

interface IHttpOptions {
  headers?: HttpHeaders | {
    [header: string]: string | string[];
  };
  observe?: 'body';
  params?: HttpParams | {
    [param: string]: string | string[];
  };
  reportProgress?: boolean;
  responseType?: 'json';
  withCredentials?: boolean;
}