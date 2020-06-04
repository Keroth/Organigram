import { Component, OnInit, Input, Inject } from '@angular/core';
import { OrgUnit } from '../_models/OrgUnit';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import {FormBuilder, FormControl, FormGroup} from '@angular/forms';
import { OrgUnitService } from '../_services/OrgUnit.service';

export interface DialogData {
  orgUnit: OrgUnit;
  state: string;
}

@Component({
  selector: 'app-orgUnit-form',
  templateUrl: './orgUnit-form.component.html',
  styleUrls: ['./orgUnit-form.component.css']
})
export class OrUnitFormComponent implements OnInit {
  commitButtonText: string;
  fieldState: boolean;
  constructor(
    private orgUnitService: OrgUnitService,
    public dialogRef: MatDialogRef<OrUnitFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) {}

  ngOnInit() {
    if (this.data.state === 'add') {
      this.commitButtonText = 'Hinzufügen';
      this.fieldState = false;
    } else if (this.data.state === 'change') {
      this.commitButtonText = 'Ändern';
      this.fieldState = false;
    } else {
      this.commitButtonText = '';
      this.fieldState = true;
    }


  }
  onCommit(){
    console.log("Commit", this.data.state);
    if (this.data.state === 'add') {
      this.orgUnitService.addOrgUnit(this.data.orgUnit);
    } else {
      this.orgUnitService.changeOrgUnit(this.data.orgUnit);
    }
    this.onClose();
  }

  onClose(){
    this.dialogRef.close();
  }
}
