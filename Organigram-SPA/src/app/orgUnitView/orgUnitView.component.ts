import { Component, OnInit, CUSTOM_ELEMENTS_SCHEMA, ViewChild  } from '@angular/core';
import { OrgUnit } from '../_models/OrgUnit';
import { OrgUnitService } from '../_services/OrgUnit.service';
import { AlertifyService } from '../_services/alertify.service';
import {NestedTreeControl} from '@angular/cdk/tree';
import {MatTreeNestedDataSource} from '@angular/material/tree';


@Component({
  selector: 'app-orgUnitView',
  templateUrl: './orgUnitView.component.html',
  styleUrls: ['./orgUnitView.component.css']
})


export class orgUnitViewComponent implements OnInit {
  treeControl = new NestedTreeControl<OrgUnit>(node => node.children);
  dataSource = new MatTreeNestedDataSource<OrgUnit>();

  orgUnits: OrgUnit[];
  constructor(private orgUnitService: OrgUnitService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.orgUnitService.orgUnit.subscribe(
      orgUnit => {
        console.log("subscribe: ", orgUnit);
        this.dataSource.data = orgUnit;
      }
    );

    this.loadOrgUnits();
  }

  loadOrgUnits() {
    this.orgUnitService.getOrgUnits();
  }

  hasChild = (_: number, node: OrgUnit) => !!node.children && node.children.length > 0;

}
