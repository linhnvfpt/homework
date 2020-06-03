import { Component, OnInit, Inject } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

export interface DialogData {
  animal: string;
  name: string;
}

@Component({
  selector: 'app-choosen-component',
  templateUrl: './choosen-component.component.html',
  styleUrls: ['./choosen-component.component.css']
})
export class ChoosenComponentComponent implements OnInit {

  constructor (public dialogRef: MatDialogRef<ChoosenComponentComponent>,
  @Inject(MAT_DIALOG_DATA) public data: DialogData) { }

  ngOnInit(): void {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
