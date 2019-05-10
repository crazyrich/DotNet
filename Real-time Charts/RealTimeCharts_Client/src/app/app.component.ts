import { Component, OnInit } from '@angular/core';
import { SingalRService } from './services/singal-r.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  public chartOptions: any = {
    scaleShowVerticalLines: true,
    responsive: true,
    scales: {
      yAxes: [{
        ticks: {
          beginAtZero: true
        }
      }]
    }
  };
  public chartLabels: string[] = ['Real time data for the chart'];
  public chartType = 'bar';
  public chartLegend = true;
  public colors = [{ backgroundColor: '#5491DA' }, { backgroundColor: '#E74C3C' },
  { backgroundColor: '#82E0AA' }, { backgroundColor: '#E5E7E9' }]

  constructor(public signalRService: SingalRService, private http: HttpClient) { }

  ngOnInit() {
    this.signalRService.startConnection();
    this.signalRService.addTransferChartDataListener();
    this.startHttpRequest();
  }

  startHttpRequest(): any {
    this.http.get('https://localhost:5001/api/chart')
      .subscribe(res => {
        console.log(res);
      });
  }
}
