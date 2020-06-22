import {Component, OnInit} from '@angular/core';
import {MakeService} from '../services/make.service';
import {FeatureService} from '../services/feature.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  models: any[];
  features: any[];
  vehicle: any = {};

  constructor(private makeService: MakeService,
              private featureService: FeatureService) {
  }

  ngOnInit(): void {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes;
    });

    this.featureService.getFeatures().subscribe(features => {
      this.features = features;
    });
  }

  onMakeChange() {
    let selectedMake = this.makes.find(x => x.id == this.vehicle.make);

    this.models = selectedMake ? selectedMake.models : [];
  }

}
