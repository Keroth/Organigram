import { Component, OnInit, Input } from '@angular/core';
import { OrgUnit } from '../_models/OrgUnit';
import { MatDialog} from '@angular/material/dialog';
import { OrUnitFormComponent } from '../orgUnit-form/orgUnit-form.component';


@Component({
  selector: 'app-orgUnit-treeItem',
  templateUrl: './orgUnit-treeItem.component.html',
  styleUrls: ['./orgUnit-treeItem.component.css']
})
export class OrgUnitTreeItemComponent implements OnInit {
  @Input() orgUnit: OrgUnit;

  constructor(
    private dialog: MatDialog
  ) { }

  ngOnInit() {
  }

  onAdd(){
    let newOrgUnit: any = {};
    newOrgUnit.parentId = {...this.orgUnit}.id;
    this.dialog.open(OrUnitFormComponent, {data: { orgUnit: newOrgUnit, state: 'add'}});
  }

  onView(){
    this.dialog.open(OrUnitFormComponent, {data: { orgUnit: {...this.orgUnit}, state: 'view'}});
  }

  onEdit(){
    this.dialog.open(OrUnitFormComponent, {data: { orgUnit: {...this.orgUnit}, state: 'change'}});
  }

}
