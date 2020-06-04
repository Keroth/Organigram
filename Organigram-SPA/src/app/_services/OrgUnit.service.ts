import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { OrgUnit } from '../_models/OrgUnit';

const httpOptions = {
  headers: new HttpHeaders({
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
};

@Injectable({
  providedIn: 'root'
})
export class OrgUnitService {
  baseUrl = environment.apiUrl + 'orgobject/';
  orgUnit: BehaviorSubject<OrgUnit[]> = new BehaviorSubject([]);

constructor(private http: HttpClient) { }

  getOrgUnits(): void
  {
    console.log("getOrgUnits")
    this.http.get<OrgUnit[]>(this.baseUrl, httpOptions).subscribe(
      orgUnits => this.orgUnit.next(orgUnits)
    );
  }

  getOrgUnit(id): Observable<any>
  {
    return this.http.get<any>(this.baseUrl + 'detail/' + id, httpOptions);
  }

  addOrgUnit(orgUnit: OrgUnit)
  {
    this.http.post<OrgUnit>(this.baseUrl + 'create/', orgUnit, httpOptions).subscribe(
      orgUnits => this.getOrgUnits()
    );
  }

  changeOrgUnit(orgUnit: OrgUnit)
  {
    console.log("changeOrgUnit")
    this.http.post<OrgUnit>(this.baseUrl + 'update/', orgUnit, httpOptions).subscribe(
      orgUnits => this.getOrgUnits()
    );
  }

}
