import TekizComponentBase from "@/shared/application/Tekiz-component-base";
import { Component, Prop } from "vue-property-decorator";

@Component
export default class ChangePasswordComponent extends TekizComponentBase {
  @Prop() public changePasswordDialog!: boolean;
  @Prop() public logOut: any;
  public refs = this.$refs as any;
  public errors: INameValueDto[] = [];
  public changePasswordInput = {} as IChangePasswordInput;
  public dialog = false;

  public mounted() {
    this.$root.$on("changePasswordDialogChanged", (dialog: boolean) => {
      this.dialog = dialog;
    });
  }

  public save() {
    if (this.refs.form.validate()) {
      this.TekizService.post<IChangePasswordOutput>(
        "/api/changePassword",
        this.changePasswordInput
      ).then((response) => {
        if (!response.isError) {
          this.dialog = false;
          this.swalToast(2000, "success", this.$t("Successful").toString());
          this.logOut();
        } else {
          this.errors = response.errors;
        }
      });
    }
  }
}
