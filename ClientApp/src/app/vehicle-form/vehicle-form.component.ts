import {Component, OnInit} from '@angular/core';
import {MakeService} from "../services/make.service";

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  vehicle: any = {};
  models: any[];

  constructor(private makeService: MakeService) {
  }

  ngOnInit(): void {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes;});
  }

  onMakeChange() {
    let selectedMake = this.makes.find(x => x.id == this.vehicle.make);

    this.models = selectedMake ? selectedMake.models : [];
  }

}
