angular.module("ngCribs").factory("cribsFactory", function ($http) {

  async function getDevices() {
      try {
          const response = await $http.get("/api/Device");
          return response.data.result;
      } catch (error) {
          return "error: " + error;
      }
  }

  return {
    getDevices: getDevices,
  };
});
