import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { ChoosenComponentComponent } from './choosen-component/choosen-component.component'

export interface Element {
  mainsize: number;
}

const BRANCH_PIPE_DATA: Element[] = [
  {mainsize: 48},
  {mainsize: 46},
  {mainsize: 44},
  {mainsize: 42},
  {mainsize: 40},
  {mainsize: 38},
  {mainsize: 36},
  {mainsize: 34},
  {mainsize: 32},
  {mainsize: 30},
  {mainsize: 28},
  {mainsize: 26},
  {mainsize: 24},
  {mainsize: 22},
  {mainsize: 20},
  {mainsize: 18},
  {mainsize: 16},
  {mainsize: 14},
  {mainsize: 12},
  {mainsize: 10},
  {mainsize: 8},
  {mainsize: 6},
  {mainsize: 5},
  {mainsize: 4},
  {mainsize: 3.5},
  {mainsize: 3},
  {mainsize: 2.5},
  {mainsize: 2},
  {mainsize: 1.5},
  {mainsize: 1.25},
  {mainsize: 1},
  {mainsize: 0.75},
  {mainsize: 0.5},
  {mainsize: 0.375},
  {mainsize: 0.25},
  {mainsize: 0.125},
];

interface Comp {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'angular material';
  col_width:string = '';
  animal: string;
  name: string;

  displayedColumns: string[] = ['Inch','0.125', '0.25', '0.375', '0.5', '0.75','1','1.25','1.5','2','2.5','3','3.5','4','5','6','8','10','12','14','16','18','20','22','24','26','28','30','32','34','36','38','40','42','44','46','48'];
  dataSource = BRANCH_PIPE_DATA;

  comps: Comp[] = [
    {value: '0', viewValue: '[R] Reducing Tee / Cross'},
    {value: '1', viewValue: '[O] O-let'},
    {value: '2', viewValue: '[C] Half Coupling'},
    {value: '3', viewValue: '[S] Stub in / OTAP'}
  ];

  constructor(public dialog: MatDialog) { }

  ngOnInit() {
    let col_len = this.displayedColumns.length;
    let col_width = 100 / col_len;
    this.col_width = col_width.toString();
  }

  onClickCell(event:Event):void {
    // var rect = element.getBoundingClientRect();
    // console.log(rect.top, rect.right, rect.bottom, rect.left);
    let mouseEvent:MouseEvent = event as MouseEvent;
    console.log(mouseEvent.srcElement);
    console.log(mouseEvent.clientX, mouseEvent.clientY);

    const dialogRef = this.dialog.open(ChoosenComponentComponent, {
      width: '250px',
      data: {name: this.name, animal: this.animal}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.animal = result;
    });

  }
}
