<%@ Page Title="PRIDE Nomination" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row" style="padding-top: 20px">
        <div class="col-md-6 col-md-offset-3">
            <div class="panel panel-primary">
                <div class="panel-heading"><%: Title %></div>
                <div class="panel-body">
                    <div class="form-group">
                        <label class="col-md-3 control-label" for="inputRecipiant">Recipiant</label>
                        <div class="col-md-9">
                            <asp:TextBox ID="inputRecipiant" class="form-control" runat="server" autocomplete="off" />
                            <asp:AutoCompleteExtender  ID="inputRecipiant_AutoCompleteExtender" TargetControlID="inputRecipiant"
                                ServicePath="~/WebService1.asmx.cs" ServiceMethod="GetCompletionList" runat="server">
                            </asp:AutoCompleteExtender>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-3 control-label" for="inputDepartment">Department</label>
                        <div class="col-md-9">
                            <asp:TextBox ID="inputDepartment" class="form-control" runat="server" autocomplete="off" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-3 control-label" for="inputNominator">Nominator</label>
                        <div class="col-md-9">
                            <asp:TextBox ID="inputNominator" class="form-control" runat="server" autocomplete="off" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-3 control-label" for="inputType">Type</label>
                        <div class="col-md-9">
                            <asp:DropDownList ID="inputType" class="form-control" runat="server" autocomplete="off" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-md-3 control-label" for="inputReason">Reason</label>
                        <div class="col-md-9">
                            <asp:TextBox ID="inputReason" TextMode="MultiLine" Rows="6" class="form-control" style="resize: none" runat="server" autocomplete="off" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-3 col-md-offset-3">
                            <asp:Button ID="Button1" class="btn btn-default" Text="Submit" runat="server" OnClick="Button1_Click"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>