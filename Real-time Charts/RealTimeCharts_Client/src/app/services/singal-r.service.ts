import { Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr';
import { ChartModel } from '../common/chartmodel.interface';
@Injectable()
export class SingalRService {

  public data: ChartModel[];

  private hubConnection: signalR.HubConnection;
  public startConnection() {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:5001/chart')
      .build();

    this.hubConnection
      .start()
      .then(() => console.log('Connection Started !'))
      .catch(err => console.log('Error while starting connection:' + err));

  }

  public addTransferChartDataListener() {
    this.hubConnection.on('transferChartData', (result) => {
      this.data = result;
      console.log(result);
    });
  }

}
