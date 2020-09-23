<template>
  <div class="dt__content dt__content--main">
    <section class="dt__section dt__section--main container columns is-multiline is-centered">
      <div class="column columns is-full is-centered">
        <h1 class="column is-2"><b-image class="dt__logo dt__logo--main" alt="Oauth service With DeadlyTrade" :src="require('@/assets/img/signature.png')" lazy /></h1>
      </div>
      <ul class="column columns is-half is-multiline">
        <li class="column is-full">
          <b-button icon-left="google" expanded >Sign in With Google</b-button>
        </li>
        <li class="column is-full">
          <b-button expanded>sign in with reddit</b-button>
        </li>
        <li class="column is-full">
          <b-button expanded>sign in with facebook</b-button>
        </li>
        <li class="column is-full">
          <b-button expanded>sign in with kakao</b-button>
        </li>
      </ul>
    </section>
    <b-image class="dt__image dt__image--background" :src="require('@/assets/img/main-bg.jpg')" responsive />
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import { IWeatherForecast } from '../models/IWeatherForecast';
import axios from 'axios';

@Component({
  filters: {
    capitalize: (value: string) => {
      if (!value) { return ''; }
      value = value.toString();
      return value.charAt(0).toUpperCase() + value.slice(1);
    },
  },
})
export default class Authenticate extends Vue {
  private forecasts: IWeatherForecast[] = [{ summary: 'No data.' } as IWeatherForecast];
  private forecastCols: any[] = [
    { name: 'Summary', label: 'Summary', field: (row: IWeatherForecast) => row.summary },
    { name: 'F',       label: 'F',       field: (row: IWeatherForecast) => row.temperatureF },
    { name: 'C',       label: 'C',       field: (row: IWeatherForecast) => row.temperatureC },
    { name: 'Date',     label: 'Date',   field: (row: IWeatherForecast) => row.date },
  ];
  
  
  public async mounted() {
    try {
      const authCode = await this.$gAuth.getAuthCode()
    }catch(e) {

      console.log(e);
    }
    
    
    // const response = await this.$http.post('http://your-backend-server-api-to-use-authcode', { code: authCode, redirect_uri: 'postmessage' })
    // console.log(process.env, this);
    // try {
    //   this.forecasts = (await axios.get('api/weatherforecast')).data;
    // } catch {
    //   this.forecasts = [{ summary: 'No data.' } as IWeatherForecast];
    // }
  }
}
</script>
