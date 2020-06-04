export interface OrgUnit {
    id: number;
    title: string;
    type: number;
    parentId: number;
    purpose: string;
    domains: string;
    accountabilities: string;
    assignee: string;
    children: OrgUnit[];
}
