import TekizComponentBase from "@/shared/application/Tekiz-component-base";
import { Component } from "vue-property-decorator";

@Component({
  components: {
    AsideMenu: require("@/admin/components/menu/aside-menu/aside-menu.vue")
      .default,
    TopMenu: require("@/admin/components/menu/top-menu/top-menu.vue").default,
  },
})
export default class AdminLayoutComponent extends TekizComponentBase {
  public created() {
    this.Tekiz.auth.fillProps();
  }
}
